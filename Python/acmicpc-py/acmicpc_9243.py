# 9243 파일 완전 삭제

import sys
input = sys.stdin.readline

n = int(input())
s1 = input()[:-1]
s2 = input()[:-1]

if n % 2 == 0:
  if s1 == s2:
    print("Deletion succeeded")
  else:
    print("Deletion failed")
else:
  s3 = ""
  for s in s1:
    s3 = s3 + ('1' if s == '0' else '0')
    
  if s2 == s3:
    print("Deletion succeeded")
  else:
    print("Deletion failed")

