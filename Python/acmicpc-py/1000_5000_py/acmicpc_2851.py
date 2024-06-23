# 2851 슈퍼 마리오

arr = [int(input()) for _ in range(10)]

score = 0
last = 0

for a in arr:
    if abs(score - 100) >= abs(score + a - 100):
        score = score + a
    else:
        break

print(score)
