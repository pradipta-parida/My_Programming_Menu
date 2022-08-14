public class ArithmeticDemo {

    public static void main(String[] args) {

        int result = 1 + 2;
        // addition result is now 3
        System.out.println("1 + 2 = " + result);

        int original_result = result;

        result = result - 1;
        // substraction result is now 2
        System.out.println(original_result + " - 1 = " + result);
        original_result = result;

        result = result * 2;
        // multiplication result is now 4 
        System.out.println(original_result + " * 2 = " + result);
        original_result = result;

        result = result / 2;
        // divide result is now 2
        System.out.println(original_result + " / 2 = " + result);
        original_result = result;

        result = result % 7;
        // modulus result is now 2
        System.out.println(original_result + " % 7 = " + result);
        original_result = result;
    }
}