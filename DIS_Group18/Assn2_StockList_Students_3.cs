using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param        : NA
    //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
    //return       : total value
    //return type  : decimal
    public decimal Value()
    {
      decimal value = 0.0m;

			// write your implementation here
			StockNode curr = this.head;

			if (curr.Next == null)
			{
				value = curr.StockHolding.Holdings * curr.StockHolding.CurrentPrice;
			}
			else
			{
				while (curr != null)
				{
					value += curr.StockHolding.Holdings * curr.StockHolding.CurrentPrice;
					curr = curr.Next;
				}

			}

			return value;
    }

    //param  (StockList) listToCompare     : StockList which has to comared for similarity index
    //summary      : finds the similar number of nodes between two lists
    //return       : similarty index
    //return type  : int
    public int Similarity(StockList listToCompare)
    {
      int similarityIndex = 0;

			// write your implementation here
			StockNode curr = this.head;
			while (curr != null)
			{
				StockNode curr1 = listToCompare.head;
				while (curr1 != null)
				{

					if (curr.StockHolding.Name == curr1.StockHolding.Name)
					{

						similarityIndex++;
					}
					curr1 = curr1.Next;
				}
				curr = curr.Next;

			}

			return similarityIndex;
    }

    //param        : NA
    //summary      : Print all the nodes present in the list
    //return       : NA
    //return type  : NA
    public void Print()
    {
			// write your implementation here
			if (this.head == null)
			{
				Console.WriteLine("#####Empty List#####");
			}
			else
			{
				StockNode curr = this.head;

				int ctr = 1;

				while (curr != null)
				{
					Console.WriteLine("****************Node number: " + counter + "***************");
					Console.WriteLine("Symbol: " + curr.StockHolding.Symbol);
					Console.WriteLine("Name: " + curr.StockHolding.Name);
					Console.WriteLine("Holdings: " + curr.StockHolding.Holdings);
					Console.WriteLine("CurrentPrice: " + curr.StockHolding.CurrentPrice);
					Console.WriteLine("");

					curr = curr.Next;
					ctr++;
				}
			}


		}
	}
}