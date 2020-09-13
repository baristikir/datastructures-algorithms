//
//  main.cpp
//  searchalgorithm-linear-search
//
//  Created by Baris Tikir on 13.09.20.
//  Copyright © 2020 Baris Tikir. All rights reserved.
//

#include <iostream>


// Method for searching linear O(n) in a array of integers
int linear_search(int list[], int e)
{
    // For all List elements
    for (int i = 0; i < sizeof(list); i++) {
        // Check if the searched number is equal to list element
        if (list[i] == e ) {
            // Output Index of the searched number inside the array
            return i;
        }
    }
    // As return for number not found in the given list of integers
    return -1;
}

int main(int argc, const char * argv[]) {
    int list[] = {1,2,4,5,18};
    std::cout << linear_search(list, 4);
    return 0;
}
