using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Practice2
{
	[TestFixture()]
	public class BubbleTest
	{
		BubbleSort UnitTest = new BubbleSort();

		//Input Test Cases
		[TestCase( "a", "b", "c", "d", Result = false )]
		[TestCase( "1", "2", "5", "100", Result = true )]
		[TestCase( "", "3", "7", "-998", Result = false )]
		[TestCase( "0", "0", "0", "0", Result = true )]
		[TestCase( "-3", "-54", "98", "41", Result = true )]
		[TestCase( "a", "-3", ".", "6", Result = false )]
		[TestCase( "one", "two", "cat", "ten", Result = false )]
		[TestCase( "-10000", "1", "-1", "10000", Result = true )]

		[Test()]
		//Run the Input Test
		public bool InputTest( string szInput0, string szInput1, string szInput2, string szInput3 )
		{
			//int[] nToInt = new int[ 4 ];
			int[] nToInt = new int[] { 1, 2, 3, 4 };
			string[] szTotalInput = new string[ 4 ];
			szTotalInput[ 0 ] = szInput0;
			szTotalInput[ 1 ] = szInput1;
			szTotalInput[ 2 ] = szInput2;
			szTotalInput[ 3 ] = szInput3;
			return UnitTest.CheckInput( szTotalInput, ref nToInt );
		}

		//Test Cases
		[TestCase( -3, 3 )]
		[TestCase( 5, 5 )]
		[TestCase( 69, 20 )]
		[TestCase( -10, -23 )]

		//Run the Swap Test
		[Test()]
		public void SwapTest( int nSwap1, int nSwap2 )
		{
			int nTemp1 = nSwap1;
			int nTemp2 = nSwap2;

			UnitTest.DoSwap( ref nSwap1, ref nSwap2 );
			Assert.AreEqual( nTemp1, nSwap2 );
			Assert.AreEqual( nTemp2, nSwap1 );
			return;
		}

		// Bubble Sort Test Cases
		[TestCase( new int[] { 4, 3, 2, 1 }, Result = new int[] { 1, 2, 3, 4 } )]
		[TestCase( new int[] { -1, -2, -3, -4 }, Result = new int[] { -4, -3, -2, -1 } )]
		[TestCase( new int[] { 12345, -999, 321, 777 }, Result = new int[] { -999, 321, 777, 12345 } )]
		[TestCase( new int[] { 0, 0, 0, 0 }, Result = new int[] { 0, 0, 0, 0 } )]
		[TestCase( new int[] { 100000, 100000, 100, 0 }, Result = new int[] { 0, 100, 100000, 100000 } )]

		// Run the Bubble Sort test
		[Test()]
		public int[] SortTest( int[] nSortArray )
		{
			UnitTest.GetSort( nSortArray );
			return nSortArray;
		}
	}
}
