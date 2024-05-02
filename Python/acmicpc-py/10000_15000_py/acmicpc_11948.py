# 11948 과목선택

arr = [int(input()) for _ in range(6)]
s = sum(sorted(arr[:4], reverse=True)[:3]) + sorted(arr[4:], reverse=True)[0]
print(s)