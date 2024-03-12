# 1233 주사위

s1, s2, s3 = map(int, input().split())

dic = {}
for i in range(1, s1 + 1):
  for j in range(1, s2 + 1):
    for k in range(1, s3 + 1):
      s = i + j + k
      if s in dic:
        dic[s] = dic[s] + 1
      else:
        dic[s] = 1

m = 0
result = 0
for i in dic:
  if dic[i] > m:
    m = dic[i]
    result = i

print(result)
  