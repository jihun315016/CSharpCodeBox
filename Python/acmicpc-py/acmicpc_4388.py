# 4388 받아올림

import sys
input = sys.stdin.readline

aa = 'abc'

while True:
  a, b = input().split()
  carry = 0
  
  if a == '0' and b == '0':
    break

  a = list(a[::-1])
  b = list(b[::-1])
  
  if len(a) > len(b):
    b = b + [0] * (len(a) - len(b))
  else:
    a = a + [0] * (len(b) - len(a))
    
  for i in range(len(a)):
    k = int(a[i]) + int(b[i])
    if k >= 10:
      carry = carry + 1
      if i + 1 < len(a):
        a[i + 1] = str(int(a[i + 1]) + 1)
        
  print(carry)
  