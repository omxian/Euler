--[[
https://projecteuler.net/problem=28

题目比较简单就是求一个n*n矩阵，对角线的和，这个矩阵根据顺时针方向生成：

暴力计算：
想了下其实要的是对角线元素的和，所以怎么生成其实对结果不影响。
可以让左上角第一个为最大的元素，这样比较容易用生成矩阵，当横向、纵向idx相等时则认为是对角线元素。

观察规律：
似乎非对角线元素的间隔为…,8,6,4,2,0
如(只考虑奇数的矩形大小，偶数规律似乎不一样）
25(当前在第三层） -> 21 -> 17 -> 13 [间隔为4]
9(当前第二层) -> 7 -> 5 -> 3 [间隔为2]
1(当前第一层）

每层起始的值如何计算,（1+2*(n-1)）的平方,因此可以简单计算出来结果，当然代码不知道在干嘛。
]]

local stop_num = 1001 *1001  
local sum = 1
local cur_num = 1
local cur_layer = 1
local space = 0

while (cur_num <= stop_num) do
  cur_layer = cur_layer + 1
  space = space + 2
  cur_num = math.pow((1+2*(cur_layer-1)),2)
  for i=0,3 do
      sum = sum + cur_num - space*i
  end
  cur_num = math.pow((1+2*(cur_layer)),2)
end
print(sum)
