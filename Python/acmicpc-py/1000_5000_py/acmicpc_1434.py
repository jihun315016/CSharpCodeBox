# 1434 책 정리

n, m = map(int, input().split())
aArr = list(map(int, input().split()))
bArr = list(map(int, input().split()))

cur = 0 # 현재 박스 인덱스

for b in bArr:
    if aArr[cur] < b:
        cur = cur + 1
        
    aArr[cur] = aArr[cur] - b

print(sum(aArr))
