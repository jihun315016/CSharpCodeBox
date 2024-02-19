# 21567 숫자의 개수 2

import sys
input = sys.stdin.readline

a = int(input())
b = int(input())
c = int(input())

k = a * b * c
dic = {}
for i in range(10):
  dic[i] = 0
        
while k > 0:
  n = k % 10
  k = k // 10  
  dic[n] = dic[n] + 1

for i in range(10):
  print(dic[i])
  