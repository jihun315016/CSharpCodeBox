# 10707 수도요금

arr = [int(input()) for _ in range(5)]

xBill = arr[4] * arr[0]

yAdded = arr[4] - arr[2]
if yAdded < 0:
    yAdded = 0
yBill = arr[1] + yAdded * arr[3]

print(min(xBill, yBill))
