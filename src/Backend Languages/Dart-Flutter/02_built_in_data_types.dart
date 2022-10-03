/*
  Dart has special support for these data types

   . Numbers - int, double
   . Strings - 
   . Booleans - 
   . Lists(also known as Arrays)
   . Maps
   . Runes(for expressing unicode characters in a string)
   . Symbols
   
   Note:- All Data types in Dart are objects.
          Therefore, values are by default null.
 */
void main(List<String> arguments) {

	// Numbers: int
	int score = 23;
	var count = 23;     // It is inferred as integer automatically by compiler
	int hexValue = 0xEADEBAEE;

	// Numbers: double
	double percentage = 93.4;
	var percent = 82.533;  // It is inferred as double automatically by compiler
	double exponents = 1.42e5; 

	// Strings
	String name = "Henry";
	var company = "Google"; // It is inferred as string automatically by compiler

	// Boolean
	bool isValid = true;
	var isAlive = false; // It is inferred as Boolean automatically by compiler

	print(score);
	print(exponents);

	// NOTE: All data types in Dart are Objects.
	// Therefore, their initial value is by default 'null'
}
