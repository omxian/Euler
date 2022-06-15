--[[
做题前思考：

需要计算特定规则表达式的从0开始连续素数的数量，返回最大的连续素数的参数成绩，给了个例子。
 n*n + n + 41 ，0<=n<=39都是素数，最大连续素数40, 他的系数乘积为 1 * 41 =41

肉眼看过去最简单的暴力枚举：
a = -999 -> 999
b = -1000 -> 1000
n = 0 当计算出来结果为素数则 +1，如果不是素数比较长度 n+1 与保存的值哪个大，大的保留系数乘积

一些优化：
cache 素数计算结果
cache n*n
由素数定义可知n=0时b需要大于等于2,因此b的取值范围可以缩减为 b = 2 -> 1000
计算b的这一轮循环前，先计算出 n*n + an 的值

瓶颈：
目测瓶颈应该在于后面计算出来的很大的数字，要计算这个数字是不是素数，需要很多遍历次数
可以优化素数的计算方式，素数筛，提前cache小->大素数的计算结果，但不知道需要计算的数字有多大。
]]

local prime_cache = {}
local gen_prime = function(num)
  for i=2, num do
    prime_cache[i] = true
  end
  for i=2, num do
    --如果是素数，则当前idx倍数的都不是素数
    if prime_cache[i] then
      local cur_idx = i + i
      while(cur_idx < num) do
        prime_cache[cur_idx] = false
        cur_idx = cur_idx + i
      end
    end
  end
end
gen_prime(10000000)

local is_prime = function(num) 
    return prime_cache[num]
end

local max_n = 40
local result = 41
for a=-999, 999 do
  for b=2, 1000 do
    local i = 0
    local temp
    while(true) do
      temp = i * i + a * i + b
      if is_prime(temp) then
        i = i + 1  
      else
        if i + 1 > max_n then
          max_n = i + 1
          result = a * b
        end
        break
      end
    end
  end
end

print(result)
