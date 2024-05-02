# 2991 사나운 개

import sys
input = sys.stdin.readline

def Attack(x, y):
  temp = []
  while len(temp) <= 1000:
    temp = temp + [1] * x
    temp = temp + [0] * y

  return temp

a, b, c, d = map(int, input().split())
arr = list(map(int, input().split()))

attackArr1 = Attack(a, b)
attackArr2 = Attack(c, d)

for i in range(len(arr)):
  time = arr[i] - 1
  print(attackArr1[time] + attackArr2[time])
