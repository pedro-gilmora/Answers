# Answers to GSI test

## Exercise 1 - Find smallest positive not listed
```csharp
private static int Solution(params int[] arr)
{
	int len = arr.Length, max = 0;
	//sort the array and find the minimum positive and maximum
	for (int i = 0, temp; i < len; max = Math.Max(max, arr[i]), i++
	)
		for (int j = i + 1; j < arr.Length; j++)
			if (arr[i] > arr[j])
			{
					temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
			}
	//Find sequence differences
	for (int j = 0; j < len; j++) //i => current | j => next					  
		if (j + 1 < len && arr[j + 1] > 1 && arr[j + 1] - arr[j] > 1)//if next is positive and next - current > 1
			return arr[j] < 0 ? arr[j + 1] - 1 : arr[j] + 1;//if current is negative then next - 1, else current + 1

	return max > -1 ? max + 1 : 1;//if minimum positive > 1 then 1 else if max is not negative then max + 1 else 1 
}
```

## Exercise 2 - Find the bug line

```csharp
for (int i = 1; i < numbers.Length; i++)
            |^| Array evaluations must start at zero
```

## Exercise 3 - Bugs Manager Web App

### [👉BugsManager Project ASP.NET Core MVC 5👈](https://github.com/pedro-gilmora/Answers/tree/master/BugsManager)

