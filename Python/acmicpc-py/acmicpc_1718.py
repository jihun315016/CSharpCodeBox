# 1718 암호

import math

a = input() # 평문
b = input() # 암호화키

if len(a) > len(b):
  drainage = math.ceil(len(a) - len(b) / len(b)) # 배수
  b = b * (drainage + 1)

for i in range(len(a)):
  if a[i] == ' ':
    print(' ', end = '')
  else:
    k = ord(a[i]) - ord(b[i]) - 1
    k = k + ord('a')
  
    if k < ord('a'):
      k = k + 26
  
    print(chr(k), end='')
  
  