# 2480 주사위 세개

arr = sorted(list(map(int, input().split())))

if arr[0] == arr[2]:
    # 정렬했는데 첫 번째랑 마지막 값이 같으면 다 똑같은 값
    print(10000 + arr[0] * 1000)
elif arr[0] == arr[1]:
    print(1000 + arr[1] * 100)
elif arr[1] == arr[2]:
    print(1000 + arr[1] * 100)
else:
    print(max(arr) * 100)
