using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice2
{
	public partial class BubbleSortUI : Form
	{
		public BubbleSortUI()
		{
			InitializeComponent();
			m_BubbleSorted = new BubbleSort();
		}
	}

	public partial class BubbleSortUI : Form
	{
		BubbleSort m_BubbleSorted;
		void btn_sort_Click( object sender, EventArgs e )
		{
			string[] szCheckArray = new string[ 4 ];
			szCheckArray[ 0 ] = this.txtNumber1.Text;
			szCheckArray[ 1 ] = this.txtNumber2.Text;
			szCheckArray[ 2 ] = this.txtNumber3.Text;
			szCheckArray[ 3 ] = this.txtNumber4.Text;

			// Step 1. Check all the input are integer or not, and put the value into sorting array
			int[] nSortArray = new int[ 4 ];
			if( m_BubbleSorted.CheckInput( szCheckArray, ref nSortArray ) == false ) {
				MessageBox.Show( "Input Intergers" );
				return;
			}

			// Step 2. Run Bubble Sort
			m_BubbleSorted.GetSort( nSortArray );

			// Step 3. Put the sorting result back.
			txtNumber1.Text = Convert.ToString( nSortArray[ 0 ] );
			txtNumber2.Text = Convert.ToString( nSortArray[ 1 ] );
			txtNumber3.Text = Convert.ToString( nSortArray[ 2 ] );
			txtNumber4.Text = Convert.ToString( nSortArray[ 3 ] );
			return;
		}
	}
}