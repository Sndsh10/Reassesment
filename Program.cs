// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
static class DistanceConverterClass{
    public static string fromUnitChoice, toUnitChoice;
    public static string fromUnit="";
    public static string toUnit="";
    public static double valueToConvert;
    public static string convertMilesToMetres(double valueInMiles){
        double valueInMetres = Math.Round((valueInMiles*(double)1609.344),2);
        return valueInMetres.ToString("f2");
    }
    public static string convertMilesToFeet(double valueInMiles){
        double valueInFeet = Math.Round((valueInMiles*(double)5280),2);
        return valueInFeet.ToString();
    }
    public static string convertMilesToKilometres(double valueInMiles){
        double valueInKilometres = Math.Round((valueInMiles*(double)1.609),3);
        return valueInKilometres.ToString("f3");
    }
    public static string convertMilesToCentimetres(double valueInMiles){
        double valueInCentimetres = Math.Round((valueInMiles*(double)160935),2);
        return valueInCentimetres.ToString("f1");
    }
    public static string convertMilesToInches(double valueInMiles){
        double valueInInches = Math.Round((valueInMiles*(double)63360.2),2);
        return valueInInches.ToString("f1");
    }
    public static string convertFeetToMetres(double valueInFeet){
        double valueInMetres = Math.Round(((double)(1609.34/5280)*(double)valueInFeet),2);
        return valueInMetres.ToString("f1");
    }
    public static string convertFeetToMiles(double valueInFeet){
        double valueInMiles = Math.Round((valueInFeet/(double)5280),5);
        return valueInMiles.ToString("f1");
    }
    public static string convertFeetToKilometres(double valueInFeet){
        double valueInKilometres = Math.Round(((double)(0.00003)*(double)valueInFeet),2);
        return valueInKilometres.ToString("f1");
    }
    public static string convertFeetToCentimetres(double valueInFeet){
        double valueInCentimetres = Math.Round(((double)30.48*(double)valueInFeet),2);
        return valueInCentimetres.ToString("f1");
    }
    public static string convertFeetToInches(double valueInFeet){
        double valueInInches = Math.Round(((double)12*(double)valueInFeet),2);
        return valueInInches.ToString("f1");
    }
    public static string convertMetresToFeet(double valueInMetres){
        double valueInFeet = Math.Round(((double)(5280/1609.344)*(double)valueInMetres),5);
        return valueInFeet.ToString("f5");
    }
    public static string convertMetresToMiles(double valueInMetres){
        double valueInMiles = Math.Round(((double)valueInMetres/(double)1609.344),5);
        return valueInMiles.ToString("f1");
    }
    public static string convertMetresToKilometres(double valueInMetres){
        double valueInKilometres = Math.Round(((double)(1/1000)*(double)valueInMetres),5);
        return valueInKilometres.ToString("f2");
    }
    public static string convertMetresToCentimetres(double valueInMetres){
        double valueInCentimetres = Math.Round(((double)100*(double)valueInMetres),5);
        return valueInCentimetres.ToString("f2");
    }
    public static string convertMetresToInches(double valueInMetres){
        double valueInInch = Math.Round(((double)(39.37)*(double)valueInMetres),5);
        return valueInInch.ToString("f3");
    }
    public static string convertKilometresToMiles(double valueInKilometres){
        double valueInMiles = Math.Round(((double)(0.621)*(double)valueInKilometres),5);
        return valueInMiles.ToString("f5");
    }
    public static string convertKilometresToFeet(double valueInKilometres){
        double valueInFeet = Math.Round(((double)(3280.8)*(double)valueInKilometres),5);
        return valueInFeet.ToString("f5");
    }
    public static string convertKilometresToMetres(double valueInKilometres){
        double valueInMetres = Math.Round(((double)1000*(double)valueInKilometres),5);
        return valueInMetres.ToString("f5");
    }
    public static string convertKilometresToCentimetres(double valueInKilometres){
        double valueInCentimetres = Math.Round(((double)(100000)*(double)valueInKilometres),5);
        return valueInCentimetres.ToString("f5");
    }
    public static string convertKilometresToInches(double valueInKilometres){
        double valueInInches = Math.Round(((double)(39370.07)*(double)valueInKilometres),5);
        return valueInInches.ToString("f5");
    }
    public static string convertCentimetresToMiles(double valueInCentimetres){
        double valueInMiles = Math.Round(((double)(0.0000062)*(double)valueInCentimetres),5);
        return valueInMiles.ToString("f5");
    }
    public static string convertCentimetresToFeet(double valueInCentimetres){
        double valueInFeet = Math.Round(((double)(0.0328)*(double)valueInCentimetres),5);
        return valueInFeet.ToString("f5");
    }
    public static string convertCentimetresToMetres(double valueInCentimetres){
        double valueInMetres = Math.Round(((double)(0.01)*(double)valueInCentimetres),5);
        return valueInMetres.ToString("f5");
    }
    public static string convertCentimetresToKilometres(double valueInCentimetres){
        double valueInKilometres = Math.Round(((double)(0.00001)*(double)valueInCentimetres),5);
        return valueInKilometres.ToString("f5");
    }
    public static string convertCentimetresToInches(double valueInCentimetres){
        double valueInInches = Math.Round(((double)(0.3937)*(double)valueInCentimetres),5);
        return valueInInches.ToString("f5");
    }
    public static string convertInchesToMiles(double valueInInches){
        double valueInMiles = Math.Round(((double)(0.0000157)*(double)valueInInches),5);
        return valueInMiles.ToString("f5");
    }
    public static string convertInchesToFeet(double valueInInches){
        double valueInFeet = Math.Round(((double)(0.08333)*(double)valueInInches),5);
        return valueInFeet.ToString("f5");
    }
    public static string convertInchesToMetres(double valueInInches){
        double valueInMetres = Math.Round(((double)(0.0254)*(double)valueInInches),5);
        return valueInMetres.ToString("f5");
    }
    public static string convertInchesToCentimetres(double valueInInches){
        double valueInCentimetres = Math.Round(((double)(2.54)*(double)valueInInches),5);
        return valueInCentimetres.ToString("f5");
    }
    public static string convertInchesToKilometres(double valueInInches){
        double valueInKilometres = Math.Round(((double)(0.0000254)*(double)valueInInches),5);
        return valueInKilometres.ToString("f5");
    }
    public static void handleFromUnitChoiceSelection(){
        switch(fromUnitChoice){
            case "1":
                fromUnit="Miles";
                break;
            case "2":
                fromUnit="Feet";
                break;
            case "3":
                fromUnit="Metres";
                break;
            case "4":
                fromUnit="Inch";
                break;
            case "5":
                fromUnit="Kilometres";
                break;
            case "6":
                fromUnit="Centimetres";
                break;
            default:
                break;
        }
    }
    public static void handleToUnitChoiceSelection(){
        switch(toUnitChoice){
            case "1":
                toUnit="Miles";
                break;
            case "2":
                toUnit="Feet";
                break;
            case "3":
                toUnit="Metres";
                break;
            case "4":
                toUnit="Inch";
                break;
            case "5":
                toUnit="Kilometres";
                break;
            case "6":
                toUnit="Centimetres";
                break;
            default:
                break;
        }
    }
    public static void performConversion(){
        if((fromUnit=="Miles")&&(toUnit=="Miles")){
            Console.WriteLine("cannot convert miles to miles");
        }else if((fromUnit=="Feet")&&(toUnit=="Feet")){
            Console.WriteLine("cannot convert feet to feet");
        }else if((fromUnit=="Metres")&&(toUnit=="Metres")){
            Console.WriteLine("cannot convert metres to metres");
        }else if((fromUnit=="Kilometres")&&(toUnit=="Kilometres")){
            Console.WriteLine("cannot convert kilometer to kilometer");
        }else if((fromUnit=="Centimetres")&&(toUnit=="Centimetres")){
            Console.WriteLine("cannot convert centimeters to centimeters");
        }else if((fromUnit=="Inch")&&(toUnit=="Inch")){
            Console.WriteLine("cannot convert inches to inches");
        }else if((fromUnit=="Miles")&&(toUnit=="Feet")){
            Console.WriteLine(valueToConvert+" miles is equal to "+DistanceConverterClass.convertMilesToFeet(valueToConvert)+" feet.");
        }else if((fromUnit=="Miles")&&(toUnit=="Metres")){
            Console.WriteLine(valueToConvert+" miles is equal to "+DistanceConverterClass.convertMilesToMetres(valueToConvert)+" metres.");
        }else if((fromUnit=="Miles")&&(toUnit=="Kilometres")){
            Console.WriteLine(valueToConvert+" miles is equal to "+DistanceConverterClass.convertMilesToKilometres(valueToConvert)+" kilometres.");
        }else if((fromUnit=="Miles")&&(toUnit=="Centimetres")){
            Console.WriteLine(valueToConvert+" miles is equal to "+DistanceConverterClass.convertMilesToCentimetres(valueToConvert)+" centimetres.");
        }else if((fromUnit=="Miles")&&(toUnit=="Inches")){
            Console.WriteLine(valueToConvert+" miles is equal to "+DistanceConverterClass.convertMilesToInches(valueToConvert)+" inches.");
        }else if((fromUnit=="Feet")&&(toUnit=="Miles")){
            Console.WriteLine(valueToConvert+" feet is equal to "+DistanceConverterClass.convertFeetToMiles(valueToConvert)+" miles.");  
        }else if((fromUnit=="Feet")&&(toUnit=="Metres")){
            Console.WriteLine(valueToConvert+" feet is equal to "+DistanceConverterClass.convertFeetToMetres(valueToConvert)+" metres.");
        }else if((fromUnit=="Feet")&&(toUnit=="Kilometres")){
            Console.WriteLine(valueToConvert+" feet is equal to "+DistanceConverterClass.convertFeetToKilometres(valueToConvert)+" kilometres.");  
        }else if((fromUnit=="Feet")&&(toUnit=="Centimetres")){
            Console.WriteLine(valueToConvert+" feet is equal to "+DistanceConverterClass.convertFeetToCentimetres(valueToConvert)+" centimetres.");  
        }else if((fromUnit=="Feet")&&(toUnit=="Inches")){
            Console.WriteLine(valueToConvert+" feet is equal to "+DistanceConverterClass.convertFeetToInches(valueToConvert)+" inches.");  
        }else if((fromUnit=="Metres")&&(toUnit=="Feet")){
            Console.WriteLine(valueToConvert+" metres is equal to "+DistanceConverterClass.convertMetresToFeet(valueToConvert)+" feet.");
        }else if((fromUnit=="Metres")&&(toUnit=="Miles")){
            Console.WriteLine(valueToConvert+" metres is equal to "+DistanceConverterClass.convertMetresToMiles(valueToConvert)+" miles.");    
        }else if((fromUnit=="Metres")&&(toUnit=="Kilometres")){
            Console.WriteLine(valueToConvert+" metres is equal to "+DistanceConverterClass.convertMetresToKilometres(valueToConvert)+" kilometres.");    
        }else if((fromUnit=="Metres")&&(toUnit=="Centimetres")){
            Console.WriteLine(valueToConvert+" metres is equal to "+DistanceConverterClass.convertMetresToCentimetres(valueToConvert)+" centimetres.");    
        }else if((fromUnit=="Metres")&&(toUnit=="Inches")){
            Console.WriteLine(valueToConvert+" metres is equal to "+DistanceConverterClass.convertMetresToInches(valueToConvert)+" inches.");    
        }else if((fromUnit=="Kilometres")&&(toUnit=="Feet")){
            Console.WriteLine(valueToConvert+" kilometres is equal to "+DistanceConverterClass.convertKilometresToFeet(valueToConvert)+" feet.");
        }else if((fromUnit=="Kilometres")&&(toUnit=="Metres")){
            Console.WriteLine(valueToConvert+" kilometres is equal to "+DistanceConverterClass.convertKilometresToMetres(valueToConvert)+" metres.");
        }else if((fromUnit=="Kilometres")&&(toUnit=="Miles")){
            Console.WriteLine(valueToConvert+" kilometres is equal to "+DistanceConverterClass.convertKilometresToMiles(valueToConvert)+" miles.");
        }else if((fromUnit=="Kilometres")&&(toUnit=="Centimetres")){
            Console.WriteLine(valueToConvert+" kilometres is equal to "+DistanceConverterClass.convertKilometresToCentimetres(valueToConvert)+" centimetres.");
        }else if((fromUnit=="Kilometres")&&(toUnit=="Inches")){
            Console.WriteLine(valueToConvert+" kilometres is equal to "+DistanceConverterClass.convertKilometresToInches(valueToConvert)+" inches.");
        }else if((fromUnit=="Centimetres")&&(toUnit=="Feet")){
            Console.WriteLine(valueToConvert+" centimetres is equal to "+DistanceConverterClass.convertCentimetresToFeet(valueToConvert)+" feet.");
        }else if((fromUnit=="Centimetres")&&(toUnit=="Metres")){
            Console.WriteLine(valueToConvert+" centimetres is equal to "+DistanceConverterClass.convertCentimetresToMetres(valueToConvert)+" metres.");
        }else if((fromUnit=="Centimetres")&&(toUnit=="Miles")){
            Console.WriteLine(valueToConvert+" centimetres is equal to "+DistanceConverterClass.convertCentimetresToMiles(valueToConvert)+" miles.");
        }else if((fromUnit=="Centimetres")&&(toUnit=="Kilometres")){
            Console.WriteLine(valueToConvert+" centimetres is equal to "+DistanceConverterClass.convertCentimetresToKilometres(valueToConvert)+" kilometres.");
        }else if((fromUnit=="Centimetres")&&(toUnit=="Inches")){
            Console.WriteLine(valueToConvert+" centimetres is equal to "+DistanceConverterClass.convertCentimetresToInches(valueToConvert)+" inches.");
        }else if((fromUnit=="Inches")&&(toUnit=="Feet")){
            Console.WriteLine(valueToConvert+" inches is equal to "+DistanceConverterClass.convertInchesToFeet(valueToConvert)+" feet.");
        }else if((fromUnit=="Inches")&&(toUnit=="Metres")){
            Console.WriteLine(valueToConvert+" inches is equal to "+DistanceConverterClass.convertInchesToMetres(valueToConvert)+" metres.");
        }else if((fromUnit=="Inches")&&(toUnit=="Miles")){
            Console.WriteLine(valueToConvert+" inches is equal to "+DistanceConverterClass.convertInchesToMiles(valueToConvert)+" miles.");
        }else if((fromUnit=="Inches")&&(toUnit=="Centimetres")){
            Console.WriteLine(valueToConvert+" inches is equal to "+DistanceConverterClass.convertInchesToCentimetres(valueToConvert)+" centimetres.");
        }else if((fromUnit=="Inches")&&(toUnit=="Kilometres")){
            Console.WriteLine(valueToConvert+" inches is equal to "+DistanceConverterClass.convertInchesToKilometres(valueToConvert)+" kilometres.");
        }
    }
    public static string checkFromUnitChoiceValidOrNot(){
        if((fromUnitChoice=="1")||(fromUnitChoice=="2")||(fromUnitChoice=="3")||(fromUnitChoice=="4")||(fromUnitChoice=="5")||(fromUnitChoice=="6")){return "valid";}
        else{ return "invalid";}
    }
    public static string checkToUnitChoiceValidOrNot(){
        if((toUnitChoice=="1")||(toUnitChoice=="2")||(toUnitChoice=="3")||(toUnitChoice=="4")||(toUnitChoice=="5")||(toUnitChoice=="6")){return "valid";}
        else{ return "invalid";}
    }
};
static class BMICalculator{
    static double bmiCalculated=0.0;
    public static double returnBMIImperial(double feet, double inches, double stones, double pounds){
        double totalPounds = BMICalculator.returnStonesToPounds(stones)+pounds;
        double totalInches = BMICalculator.returnFeetToInches(feet)+inches;
        bmiCalculated=((totalPounds)*703)/(totalInches*totalInches);
        return bmiCalculated;
    }
    public static double returnBMIMetric(double metres, double kilograms){
        bmiCalculated=kilograms/(metres*metres);
        return bmiCalculated;
    }
    static double returnStonesToPounds(double stones){
        return 14.0*stones;
    }
    static double returnFeetToInches(double feets){
        return 12.0*feets;
    }
    public static string returnRange(double Value){
        if(Value<18.50){
            return "UnderWeight";
        }else if((Value>=18.5)&&(Value<=24.9)){
            return "Normal";
        }else if((Value>=25.0)&&(Value<=29.9)){
            return "OverWeight";
        }else if((Value>=30.0)&&(Value<=34.9)){
            return "Obese Class 1";
        }else if((Value>=35.0)&&(Value<=39.9)){
            return "Obese Class 2";
        }else if(Value<=40.0){
            return "Obese Class 3";
        }else{
            return"";
        }
    }
};
static class StudentMarks{

    static double[] marksOfStudents={0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0};
    static string marksOfStudentsInputValidOrNot="invalid";
    public static char returnGrade(double grade){
        if((grade>=70)&&(grade<=100)){
            return 'A';
        }else if((grade>=60)&&(grade<=69)){
            return 'B';
        }else if((grade>=50)&&(grade<=59)){
            return 'C';
        }else if((grade>=40)&&(grade<=49)){
            return 'D';
        }else if((grade>=0)&&(grade<=39)){
            return 'F';
        }else{return' ';}
    }
    public static string returnGradeClassification(double grade){
        if((grade>=70)&&(grade<=100)){
            return "First Class";
        }else if((grade>=60)&&(grade<=69)){
            return "Upper second class";
        }else if((grade>=50)&&(grade<=59)){
            return "Lower second class";
        }else if((grade>=40)&&(grade<=49)){
            return "Third class";
        }else if((grade>=0)&&(grade<=39)){
            return "Fail";
        }else{return" ";}
    }
    public static void outputMarks(){
        Console.WriteLine("==========================================");
        Console.WriteLine("        Listing of Student marks");
        Console.WriteLine("==========================================");
        for(int i=0;i<10;i++){
            Console.WriteLine("Student "+(i+1)+", Mark = "+marksOfStudents[i]+", Grade = "+returnGrade(marksOfStudents[i]));
        }
    }
    public static void inputMarks(){
        int i = 0;
        Console.WriteLine("\n\nInput marks for students\n\n");
        while(marksOfStudentsInputValidOrNot=="invalid"){
            if(i<11){
                double currentMark;
                Console.WriteLine("Enter mark for student "+(i+1));
                bool isDouble = Double.TryParse(Console.ReadLine(),out currentMark);
                if(isDouble){
                    marksOfStudents[i]=currentMark;
                    i=i+1;
                }else{
                    Console.WriteLine("Invalid input. Please try again. \n\n");
                }
                if((i+1)==11){
                    marksOfStudentsInputValidOrNot="valid";
                }
            }
        }
    }
    public static void returnGradeProfile(){
        Console.WriteLine("==========================================");
        Console.WriteLine("        Listing of Student grade profile");
        Console.WriteLine("==========================================");
        for(int i=0;i<10;i++){
            Console.WriteLine("Student "+(i+1)+", Grade Profile = "+returnGradeClassification(marksOfStudents[i]));
        }
    }
    public static string returnGradeStats(){
        double meanMark=0.0;
        double minimumMark=0.0;
        double maximumMark=0.0;
        double sum=0.0;
        double minMarksOfStudents;
        double maxMarksOfStudents;
        foreach (int item in marksOfStudents)
        {
            sum+=item;   
        }
        minMarksOfStudents=marksOfStudents[0];
        maxMarksOfStudents=marksOfStudents[0];
        for(int i=0;i<marksOfStudents.Length;i++){
            if(marksOfStudents[i]>maxMarksOfStudents){
                minMarksOfStudents=marksOfStudents[i];
            }
            if(marksOfStudents[i]<minMarksOfStudents){
                maxMarksOfStudents = marksOfStudents[i];
            }
        }
        double averageValue=sum/marksOfStudents.Length;
        return "average value is "+averageValue+" max is "+maxMarksOfStudents+" and min is "+minMarksOfStudents;
    }
}
class Program{

    public void runDistanceConverter(){
        string fromUnitChoiceValidOrNot = "invalid";
        string toUnitChoiceValidOrNot = "invalid";
        string valueToConvertValidOrNot = "invalid";
        Console.WriteLine("\n\n\n\n\n\n------------------------------------------");
        Console.WriteLine("BNU CO453 Applications Programming");
        Console.WriteLine("------------------------------------------\n\n");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("        App01 Distance Converter          ");
        Console.WriteLine("           By Sandesh Koirala             ");
        Console.WriteLine("------------------------------------------");
        while(fromUnitChoiceValidOrNot=="invalid"){
            Console.WriteLine(" \n \nPlease select your from unit \n\n 1. Miles \n 2. Feet \n 3. Metres \n 4. Inches \n 5. Kilometres \n 6. Centimetres \n\nPlease enter choice ");
            DistanceConverterClass.fromUnitChoice = Console.ReadLine();
            fromUnitChoiceValidOrNot = DistanceConverterClass.checkFromUnitChoiceValidOrNot();
            if(fromUnitChoiceValidOrNot=="invalid"){
                Console.WriteLine("Invalid choice. please try again. ");
            }
        }
        while(toUnitChoiceValidOrNot=="invalid"){
            Console.WriteLine("\n\nPlease select your to unit \n\n 1. Miles \n 2. Feet \n 3. Metres \n 4. Inches \n 5. Kilometres \n 6. Centimetres \n\nPlease enter choice ");
            DistanceConverterClass.toUnitChoice = Console.ReadLine();
            toUnitChoiceValidOrNot = DistanceConverterClass.checkToUnitChoiceValidOrNot();
            if(toUnitChoiceValidOrNot=="invalid"){
                Console.WriteLine("Invalid choice. please try again. ");
            }
        }
        DistanceConverterClass.handleFromUnitChoiceSelection();
        DistanceConverterClass.handleToUnitChoiceSelection();
        Console.WriteLine("\n\nYou are converting from "+DistanceConverterClass.fromUnit+" to "+DistanceConverterClass.toUnit);
            
        while(valueToConvertValidOrNot=="invalid"){
            double valueToConvert;
            Console.WriteLine("\n\nPlease enter the distance in "+DistanceConverterClass.fromUnit);
            bool isDouble = Double.TryParse(Console.ReadLine(),out valueToConvert);
            //DistanceConverterClass.valueToConvert = Convert.ToDouble(Console.ReadLine());
            if(isDouble){valueToConvertValidOrNot="valid";
                DistanceConverterClass.valueToConvert = valueToConvert;}
            else{valueToConvertValidOrNot="invalid";
            Console.WriteLine("Invalid choice. please try again. ");}
        }
        //Console.WriteLine(""+convertMetresToMiles(valueToConvert));
        DistanceConverterClass.performConversion();
        
    }
    
    public void runBMICalculator(){


        string whileChoiceUnitTypeValidOrNot = "invalid";
        string choiceUnitTypeValue="";
        double heightFeetsValue=0.0;
        double heightInchesValue=0.0;
        double heightMetresValue=0.0;
        double weightStonesValue=0.0;
        double weightPoundsValue=0.0;
        double weightKilogramsValue=0.0;
        string whileHeightFeetValidOrNot="invalid";
        string whileHeightInchesValidOrNot="invalid";
        string whileHeightMetresValidOrNot="invalid";
        string whileWeightStonesValidOrNot="invalid";
        string whileWeightPoundsValidOrNot="invalid";
        string whileWeightKilogramsValidOrNot="invalid";

        Console.WriteLine("------------------------------------------\n\n");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("        Body Mass Index Calculator          ");
        Console.WriteLine("           By Sandesh Koirala             ");
        Console.WriteLine("------------------------------------------");

        while(whileChoiceUnitTypeValidOrNot=="invalid"){

            Console.WriteLine(" \n \n\n\n 1. Metric Units \n 2. Imperial Units \n\nPlease enter you choice ");
            choiceUnitTypeValue=Console.ReadLine();

            switch(choiceUnitTypeValue){
                case "1":
                    Console.WriteLine("Metric system");
                    whileChoiceUnitTypeValidOrNot="valid";
                    break;
                case "2":
                    Console.WriteLine("Imperic system");
                    whileChoiceUnitTypeValidOrNot="valid";
                    break;
                default:
                    whileChoiceUnitTypeValidOrNot="invalid";
                    Console.WriteLine(" Invalid choice. Please try again.");
                    break;
            }
        }
        while(((whileChoiceUnitTypeValidOrNot=="valid")&&(whileHeightFeetValidOrNot=="invalid"))&&((whileChoiceUnitTypeValidOrNot=="valid")&&(whileHeightMetresValidOrNot=="invalid"))){
            bool isDouble;
            switch(choiceUnitTypeValue){
                case "1":
                    Console.WriteLine(" \n \n\n\n Enter your height in metres ");
                    isDouble = Double.TryParse(Console.ReadLine(),out heightMetresValue);
                    if(isDouble){
                        whileHeightMetresValidOrNot="valid";
                    }else{
                        Console.WriteLine("Invalid choice. please try again");
                    }
                    break;
                case "2":
                    Console.WriteLine("\n\nPlease enter your height to the nearest feet and inches");
                    Console.WriteLine(" \n \n\n\n Enter your height in feet ");
                    isDouble = Double.TryParse(Console.ReadLine(),out heightFeetsValue);
                    if(isDouble){
                        whileHeightFeetValidOrNot="valid";
                    }else{
                        Console.WriteLine("Invalid choice. please try again");
                    }
                    break;
                default:
                    break;
            }
        }
        while((whileHeightMetresValidOrNot=="invalid")&&(whileHeightFeetValidOrNot=="valid")&&(whileHeightInchesValidOrNot=="invalid")){
            Console.WriteLine(" \n \n\n\n Enter your height in inches ");
            bool isDouble = Double.TryParse(Console.ReadLine(),out heightInchesValue);
            if(isDouble){
                whileHeightInchesValidOrNot="valid";
            }else{
                Console.WriteLine("Invalid choice. please try again");
            }
        }


        while(((whileHeightMetresValidOrNot=="valid")||(whileHeightFeetValidOrNot=="valid"))&&((whileWeightKilogramsValidOrNot=="invalid")&&(whileWeightStonesValidOrNot=="invalid"))){
            bool isDouble;
            switch(choiceUnitTypeValue){
                case "1":
                    Console.WriteLine(" \n \n\n\n Enter your weight in kilograms :");
                    isDouble = Double.TryParse(Console.ReadLine(),out weightKilogramsValue);
                    if(isDouble){
                        whileWeightKilogramsValidOrNot="valid";
                    }else{
                        Console.WriteLine("Invalid choice. please try again");
                    }
                    break;
                case "2":
                    Console.WriteLine("\n\nPlease enter your weight to the nearest stones and pounds");
                    Console.WriteLine(" \n \n\n\n Enter your weight in stones :");
                    isDouble = Double.TryParse(Console.ReadLine(),out weightStonesValue);
                    if(isDouble){
                        whileWeightStonesValidOrNot="valid";
                    }else{
                        Console.WriteLine("Invalid choice. please try again");
                    }
                    break;
                default:
                    break;
            }
        }

        
        while((whileWeightKilogramsValidOrNot=="invalid")&&(whileWeightStonesValidOrNot=="valid")&&(whileWeightPoundsValidOrNot=="invalid")){
            Console.WriteLine(" \n \n\n\n Enter your weight in pounds ");
            bool isDouble = Double.TryParse(Console.ReadLine(),out weightPoundsValue);
            if(isDouble){
                whileWeightPoundsValidOrNot="valid";
            }
        }
    

        if(choiceUnitTypeValue=="1"){
            //Console.WriteLine("height in metric system is "+heightMetresValue+" metres and weight in metric system is "+weightKilogramsValue+" kilograms.");
            double valueBMI = BMICalculator.returnBMIMetric(heightMetresValue,weightKilogramsValue);
            valueBMI = Math.Round(valueBMI,2);
            Console.WriteLine("BMI is "+valueBMI.ToString("f2")+", you are in "+BMICalculator.returnRange(BMICalculator.returnBMIMetric(heightMetresValue,weightKilogramsValue))+" range");
        }else{
            //Console.WriteLine("height in imperial system is "+heightFeetsValue+" feets and "+heightInchesValue+" inches and weight in imperial system is "+weightStonesValue+" stones and "+weightPoundsValue+" pounds. ");
            double valueBMI = BMICalculator.returnBMIImperial(heightFeetsValue,heightInchesValue,weightStonesValue,weightPoundsValue);
            valueBMI = Math.Round(valueBMI,2);
            Console.WriteLine("BMI is "+valueBMI.ToString("f2")+", you are in "+BMICalculator.returnRange(BMICalculator.returnBMIImperial(heightFeetsValue,heightInchesValue,weightStonesValue,weightPoundsValue))+" range");
        }
        
        Console.WriteLine("If you are Black, Asian or other minority groups, you have a higher risk ");

    }
    
    public void runStudentMarks(){
        
        string applicationValueStudentMarks="invalid";
        string applicationCodeStudentMarksValidOrNot="invalid";
        string inputMarksIndividualMarksValidOrNot="invalid";
        Console.WriteLine("------------------------------------------\n\n");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("           Student grading app          ");
        Console.WriteLine("           By Sandesh Koirala             ");
        Console.WriteLine("------------------------------------------");

       
        while(applicationCodeStudentMarksValidOrNot=="invalid"){ 
            Console.WriteLine(" \n \n 1. Input Marks \n 2. Output Marks \n 3. Output Stats \n 4. Output grade profile \n 5. Quit \n\nPlease enter you choice ");
            applicationValueStudentMarks = Console.ReadLine();
            switch(applicationValueStudentMarks){
                case "1":
                    StudentMarks.inputMarks();
                    //applicationCodeStudentMarksValidOrNot="valid";
                    break;
                case "2":
                    StudentMarks.outputMarks();
                    //applicationCodeStudentMarksValidOrNot="valid";
                    break;
                case "3":
                    Console.WriteLine(StudentMarks.returnGradeStats());
                    break;
                case "4":
                    StudentMarks.returnGradeProfile();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }


    }
    
    public static void Main(string[] args){

        string whileChoiceApplicationValidOrNot="invalid";
        string choiceApplicationValue="";
        while(whileChoiceApplicationValidOrNot=="invalid"){

            
            Console.WriteLine("------------------------------------------\n\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("               BNU-CO453          ");
            Console.WriteLine("Select Application below :            ");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine(" \n \n 1. Distance Converter \n 2. BMI Calculator \n 3. Student Grading app \n\nPlease enter you choice ");
            choiceApplicationValue = Console.ReadLine();
            switch(choiceApplicationValue){
                case "1":
                    whileChoiceApplicationValidOrNot="valid";
                    new Program().runDistanceConverter();
                    break;
                case "2":
                    whileChoiceApplicationValidOrNot="valid";
                    new Program().runBMICalculator();
                    break;
                case "3":
                    whileChoiceApplicationValidOrNot="valid";
                    new Program().runStudentMarks();
                    break;
                default:
                    whileChoiceApplicationValidOrNot="invalid";
                    Console.WriteLine(" Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
