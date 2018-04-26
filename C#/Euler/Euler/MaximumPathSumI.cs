using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class MaximumPathSumI
    {
        List<List<int>> data;
        public int Solution(string input)
        {
            ParseData(input);
            return CountMaximumPathSum();
        }

        private void ParseData(string inputRawData)
        {
            string[] rowArr = inputRawData.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < rowArr.Length; i++)
            {
                string row = rowArr[i].Trim();
                string[] itemArr = row.Split(' ');
                List<int> itemList = new List<int>();

                foreach (string item in itemArr)
                {
                    itemList.Add(Convert.ToInt32(item, 10));
                }

                result.Add(itemList);
            }
            data = result;
        }

        struct SearchItem
        {
            public int sum;
            public int index;
        }

        /// <summary>
        /// 先考虑蛮力解决，如果效率不行在考虑使用启发式算法
        /// 从后向前算，最后遍历一次就可以找到最大的了
        /// 如果数据量太大会发生溢出
        /// </summary>
        private int CountMaximumPathSum()
        {
            List<List<SearchItem>> searchList = new List<List<SearchItem>>();

            for (int i = data.Count - 1; i >= 0; i--)
            {
                List<SearchItem> list = new List<SearchItem>();
                int prevIndex = data.Count - 2 - i;
                for (int j = 0; j < data[i].Count; j++)
                {
                    AddSearchItem(list, searchList, prevIndex, i, j);
                }
                searchList.Add(list);
            }
            return GetMaxSumInSearchList(searchList);
        }

        private int GetMaxSumInSearchList(List<List<SearchItem>> searchList)
        {
            int max = int.MinValue;
            foreach (SearchItem item in searchList[searchList.Count - 1])
            {
                max = Math.Max(item.sum, max);
            }

            return max;
        }

        private void AddSearchItem(List<SearchItem> list , List<List<SearchItem>> searchList,int prevIndex,int i,int j)
        {
            if (searchList.Count > 0)
            {
                List<SearchItem> prevList = searchList[prevIndex];
                for (int k = 0; k < prevList.Count; k++)
                {
                    SearchItem prevItem = prevList[k];
                    if (prevItem.index > (j + 1))
                    {
                        break;
                    }
                    else if (prevItem.index < j)
                    {
                        continue;
                    }
                    else
                    {
                        SearchItem item = new SearchItem();
                        item.sum = prevItem.sum + data[i][j];
                        item.index = j;
                        list.Add(item);
                    }
                }
            }
            else
            {
                SearchItem item = new SearchItem();
                item.sum = data[i][j];
                item.index = j;
                list.Add(item);
            }
        }
    }
}
