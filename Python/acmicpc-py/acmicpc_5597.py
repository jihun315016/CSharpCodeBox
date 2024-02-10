# 5597 과제 안 내신 분..?

arr = sorted([int(input()) for _ in range(28)]) + [0, 0]
idx = 0
for i in range(30):
    if arr[idx] == i + 1:
        idx = idx + 1
    else:
        print(i + 1)
