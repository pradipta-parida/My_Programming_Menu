public class Logical_BitwiseOperator {

    public static void main(String[] args) {
        int value1 = 1;
        int value2 = 2;

        /*
         * Also known as Short-Circuit Operator.
         * 
         * In Logical operations the flow checks either of the conditions.
         * e.g; if you use double ampersand and if the left hand operation
         * becomes false then it will not cover the right hand operation.It will not
         * even evaluate the right hand operation because it does not matter
         * if the left hand operation has already returned to false/ evaluated to false
         * then no matter whether right side is true or false the whole expression is
         * still going to be false.
         */

        // if condition will be true when both the conditions will be true(Logical AND)
        if ((value1 == 1) && (value2 == 2)) {
            System.out.println("value1 is 1 AND value2 is 2");
        }

        // if condition will be true when any one of the conditions will be true(Logical
        // OR)
        if ((value1 == 1) || (value2 == 1)) {
            System.out.println("value1 is 1 OR value2 is 1");
        }

        if ((value1 == 3) || (value2 == 1)) {
            System.out.println("value1 is 3 OR value2 is 1");
        }

        if ((value1 == 3) && (value2 == 1)) {
            System.out.println("value1 is 3 AND value2 is 1");
        }

        /*
         * Also known as Standard Operator. It will convert the whole program into
         * bits(0s and 1s).best used while working at machine-level understanding.
         * 
         * In Bitwise operations the operator checks both the conditions irrespective if
         * the first condition holds true/false, which in turn consumes lots of memory
         * in evaluating the conditions.
         */

        // if condition will be true when both the conditions will be true(Bitwise AND)
        if ((value1 == 3) & (value2 == 1)) {
            System.out.println("value1 is 3 AND value2 is 1");
        }

        // if condition will be true when any one of the conditions will be true(Bitwise
        // OR)
        if ((value1 == 3) | (value2 == 1)) {
            System.out.println("value1 is 3 AND value2 is 1");
        }

        // initial values
        int c = 5;
        int d = 7;

        /*
         * 5 and 7 are actually stored in Os and 1s(also known as in bits)
         * In computers memory, they are stored in standard representation.
         * 
         * For example;
         * 5 will be writtena as 0101
         * 7 will be writtena as 0111
         * 
         * Note:-
         * Here, 0 means "False" and 1 means "True".
         * 
         */

        /*
         * Bitwise AND (one of the bits need to be false(0) to become the whole
         * expression false)
         * 
         * Analogy:- As you are doing multiplication 0*0=0 ; 1*1=1 ; 0*1=0
         * 
         * 0101 & 0111 = 0101 = 5
         */

        /*
         * 0<->0 = False = 0
         * 1<->1 = True = 1
         * 0<->1 = False = 0
         * 1<->1 = True = 1
         */

        System.out.println("c&d = " + (c & d));

        /*
         * Bitwise OR (one of the bits need to be true(1) to become the whole expression
         * true)
         * 
         * Analogy:- As you are doing addition 0+0=0 ; 1+1=1 ; 0+1=1
         * 
         * 0101 | 0111 = 0111 = 7
         */

        /*
         * 0<->0 = False = 0
         * 1<->1 = True = 1
         * 0<->1 = True = 1
         * 1<->1 = True = 1
         */
        System.out.println("c|d = " + (c | d));

    }
}