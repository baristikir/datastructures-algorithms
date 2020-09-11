//
//  main.cpp
//  algorith-fibonacci
//
//  Created by Baris Tikir on 11.09.20.
//  Copyright © 2020 Baris Tikir. All rights reserved.
//

#include <iostream>
using namespace std;

unsigned long long int Fib(unsigned long long int Zahl)
{
    if(Zahl < 3)
        return 1;
    else
        return Fib(Zahl-1) + Fib(Zahl-2);
}

int main(int argc, const char * argv[]) {
    unsigned long long int Zahl;
    
    cout << "Bitte geben Sie die Zahl ein: ";
    cin >> Zahl;
    
    cout << "Die Fibonacci-Zahl von " << Zahl << " ist " << Fib(Zahl) << endl;
    
    return 0;
}
