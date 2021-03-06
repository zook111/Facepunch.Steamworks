﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Facepunch.Steamworks
{
    public partial class Client : IDisposable
    {
        private ServerList _serverlist;

        public ServerList ServerList
        {
            get
            {
                if ( _serverlist == null )
                    _serverlist = new ServerList { client = this };

                return _serverlist;
            }
        }
    }

    public partial class ServerList
    {

        public class Filter : List<KeyValuePair<string, string>>
        {
            public void Add( string k, string v )
            {
                Add( new KeyValuePair<string, string>( k, v ) );
            }

            internal IntPtr NativeArray;
            private IntPtr m_pArrayEntries;

            internal void Start()
            {
                var filters = this.Select( x =>
                {
                    return new SteamNative.MatchMakingKeyValuePair_t()
                    {
                        Key  = x.Key,
                        Value = x.Value
                    };

                } ).ToArray();

                int sizeOfMMKVP = Marshal.SizeOf(typeof(SteamNative.MatchMakingKeyValuePair_t));
                NativeArray = Marshal.AllocHGlobal( Marshal.SizeOf( typeof( IntPtr ) ) * filters.Length );
                m_pArrayEntries = Marshal.AllocHGlobal( sizeOfMMKVP * filters.Length );

                for ( int i = 0; i < filters.Length; ++i )
                {
                    Marshal.StructureToPtr( filters[i], new IntPtr( m_pArrayEntries.ToInt64() + ( i * sizeOfMMKVP ) ), false );
                }

                Marshal.WriteIntPtr( NativeArray, m_pArrayEntries );
            }

            internal void Free()
            {
                if ( m_pArrayEntries != IntPtr.Zero )
                {
                    Marshal.FreeHGlobal( m_pArrayEntries );
                }

                if ( NativeArray != IntPtr.Zero )
                {
                    Marshal.FreeHGlobal( NativeArray );
                }
            }
        }

        internal Client client;

        [StructLayout( LayoutKind.Sequential )]
        private struct MatchPair
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string key;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string value;
        }

        public Request Internet( Filter filter )
        {
            filter.Start();

            var request = new Request( client );
            request.AddRequest( client.native.servers.RequestInternetServerList( client.AppId, filter.NativeArray, (uint) filter.Count, IntPtr.Zero ) );

            filter.Free();

            return request;
        }

        public Request Custom( IEnumerable<string> serverList )
        {
            var request = new Request( client );
            request.ServerList = serverList;
            request.StartCustomQuery();
            return request;
        }

        /// <summary>
        /// History filters don't seem to work, so we don't bother.
        /// You should apply them post process'dly
        /// </summary>
        public Request History()
        {
            var request = new Request( client );
            request.AddRequest( client.native.servers.RequestHistoryServerList( client.AppId, IntPtr.Zero, 0, IntPtr.Zero ) );

            return request;
        }

        /// <summary>
        /// Favourite filters don't seem to work, so we don't bother.
        /// You should apply them post process'dly
        /// </summary>
        public Request Favourites()
        {
            var request = new Request( client );
            request.AddRequest( client.native.servers.RequestFavoritesServerList( client.AppId, IntPtr.Zero, 0, IntPtr.Zero ) );

            return request;
        }

        public void AddToHistory( Server server )
        {
            // client.native.matchmaking
        }

        public void RemoveFromHistory( Server server )
        {
            // 
        }

        public void AddToFavourite( Server server )
        {
            // client.native.matchmaking
        }

        public void RemoveFromFavourite( Server server )
        {
            // 
        }

        public bool IsFavourite( Server server )
        {
            return false;
        }
    }
}
