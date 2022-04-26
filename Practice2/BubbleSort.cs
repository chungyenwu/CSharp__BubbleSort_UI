using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2
{
	public class BubbleSort
	{
		public void DoSwap( ref int nValA, ref int nValB )
		{
			int nTemp = nValA;
			nValA = nValB;
			nValB = nTemp;
		}

		public bool CheckInput( string[] szCheckArray, ref int[] nArray )
		{
			for( int i = 0; i < szCheckArray.Length; i++ ) {
				bool bResult = Int32.TryParse( szCheckArray[ i ], out nArray[ i ] );
				if( bResult != true ) {
					return false;
				}
			}
			return true;
		}

		public void GetSort( int[] nSortArray )
		{
			//int[] sortarray = { 4, 3, 8, 56 };
			for( int i = 0; i < nSortArray.Length; i++ ) {
				for( int j = 0; j < nSortArray.Length - 1 - i; j++ ) {
					if( nSortArray[ j ] > nSortArray[ j + 1 ] ) {
						DoSwap( ref nSortArray[ j ], ref nSortArray[ j + 1 ] );
					}
				}
			}
		}
	}
}
