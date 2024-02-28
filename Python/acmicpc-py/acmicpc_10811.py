# 10811 바구니 뒤집기

n, m = map(int, input().split())
arr = [i for i in range(1, n + 1)]

for _ in range(m):
  a, b = map(int, input().split())

  # a번째부터 b번째까지 뒤집기
  tArr = arr[a - 1:b]
  tArr.reverse()
  arr[a-1:b] = tArr

print(' '.join(map(str,arr)))
