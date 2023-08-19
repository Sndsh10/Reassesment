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
class Program{
    
    public static void Main(string[] args){
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
}
