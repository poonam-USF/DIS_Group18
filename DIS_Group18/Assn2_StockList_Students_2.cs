using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //Shreyas Dalvi
    //param   (StockList)listToMerge : second list to be merged 
    //summary      : merge two different list into a single result list
    //return       : merged list
    //return type  : StockList
    public StockList MergeList(StockList listToMerge)
    {
      StockList resultList = new StockList();

            // write your implementation here
            StockNode currNd = this.head;
            resultList.head = currNd;
            currNd = listToMerge.head;
            if (listToMerge != null)
            {
                while (currNd != null)
                {
                    resultList.AddLast(currNd.StockHolding);
                    currNd = currNd.Next;
                }
            }

            return resultList;
    }

    //Shreyas Dalvi
    //param        : NA
    //summary      : finds the stock with most number of holdings
    //return       : stock with most shares
    //return type  : Stock
    public Stock MostShares()
    {
            Stock mostShareStock = null;

            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
                return mostShareStock;
            }
            else
            {
                StockNode currentnode = this.head;
                mostShareStock = currentnode.StockHolding;

                if (currentnode.Next == null)
                {
                    return mostShareStock;
                }
                else
                {
                    while (currentnode != null)
                    {
                        if (currentnode.StockHolding.Holdings > mostShareStock.Holdings)
                        {
                            mostShareStock = currentnode.StockHolding;
                        }
                        currentnode = currentnode.Next;
                    }
                    return mostShareStock;
                }

            }
        }

    //Shreyas Dalvi
    //param        : NA
    //summary      : finds the number of nodes present in the list
    //return       : length of list
    //return type  : int
    public int Length()
    {
            int length = 0;

            if (this.head == null)
            {
                return length;
            }
            else
            {
                StockNode currentnode = this.head;

                do
                {
                    currentnode = currentnode.Next;
                    length++;
                } while (currentnode != null);

            }

            return length;

        }
  }
}