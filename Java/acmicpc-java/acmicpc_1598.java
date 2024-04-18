// 1598 꼬리를 무는 숫자 나열

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n1 = sc.nextInt();
        int n2 = sc.nextInt();

        List<Integer> point1 = getPoint(n1);
        List<Integer> point2 = getPoint(n2);

        System.out.println(Math.abs(point1.get(0) - point2.get(0)) + Math.abs(point1.get(1) - point2.get(1)));
    }

    public static List<Integer> getPoint(int number) {
        int row = number % 4 - 1;
        if (row == -1) {
            row = 3;
        }

        int column = (number - 1) / 4;

        List<Integer> list = new ArrayList<>();
        return new ArrayList<Integer>(Arrays.asList(row, column));
    }
}
