# Sorting Algorithms Library

## Overview

Welcome to the **Sorting Algorithms Library** repository! This project is a comprehensive collection of various sorting algorithms implemented in C#. The library is designed for educational purposes and practical use, helping developers understand different sorting techniques and how to implement them efficiently.

## Features

- **Modular Design**: Each sorting algorithm is implemented in its own class, following a common interface.
- **Easy to Use**: Simply include the library in your project and call the sorting methods.
- **Well-documented**: Comprehensive documentation and usage examples are provided.
- **Unit Tests**: Each algorithm is thoroughly tested to ensure correctness and performance.

## Included Algorithms

- **Selection Sort**: A simple, comparison-based algorithm.
- **Insertion Sort**: An efficient algorithm for small datasets.
- **Bubble Sort**: A simple comparison-based algorithm.
- **Merge Sort**: A stable, divide-and-conquer algorithm.
- **Quick Sort**: A highly efficient divide-and-conquer algorithm.
- **Bogo Sort**: A highly inefficient algorithm that randomly shuffles the array until it is sorted. Mainly used as a humorous or educational example.

## Getting Started

### Prerequisites

- .NET Core SDK 3.1 or higher

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/FF2510/sorting-algorithms.git
    cd sorting-algorithms
    ```

2. Open the solution in Visual Studio:

    ```bash
    SortingAlgorithms.sln
    ```

3. Build the solution to restore the NuGet packages and compile the project.

4. You can also download the DLL [here](https://1drv.ms/u/s!AjzKkFpEfYCGhq0FypMd-DGNAtCyYg?e=Ge97gG).


### Usage

To use a sorting algorithm from the library, first add a reference to the `SortingAlgorithms` project in your solution. Then, you can use the sorting algorithms as follows:

```csharp
using SortingAlgorithms;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 3, 8, 4, 2 };
        
        ISortingAlgorithm sorter = new BubbleSort();
        sorter.Sort(array);
        
        Console.WriteLine(string.Join(", ", array));
    }
}

