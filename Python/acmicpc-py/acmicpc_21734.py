# 21734 SMUPC의 등장

sInput = input()

for s in sInput:
  n = ord(s)
  k = 0
  while n > 0:
    k = k + n % 10
    n = n // 10
    
  print(s * k)
  