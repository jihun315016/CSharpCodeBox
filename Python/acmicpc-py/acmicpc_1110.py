# 1110 더하기 사이클

# 주어진 입력은 최대 두 자릿수라는 보장이 있음
def cycle(k):
  r = k % 10 # 나머지
  s = k // 10 # 몫
  t = r + s
  return (t % 10) + (r * 10)
    
n = int(input())
k = cycle(n)
cnt = 1

while k != n:
  k = cycle(k)
  cnt = cnt + 1
  
print(cnt)
