# 4592 중복을 없애자

while True:
    arr = list(map(int, input().split()))
    cur = ""

    if arr[0] == 0:
        break

    for i in range(1, len(arr)):
        if cur != arr[i]:
            cur = arr[i]
            print(arr[i], end=' ')

    print('$')
