/*
Given an array of integers, calculate the ratios of its elements that are positive, negative,
 and zero. Print the decimal value of each fraction on a new line with 6 places after the decimal.

 * Complete the 'plusMinus' function below.
 *
 * The function accepts INTEGER_ARRAY arr as parameter.
 */

function plusMinus(arr) {
    // Write your code here
    let positiveSum = 0;
    let negativeSum = 0;
    let zeroSum = 0;
    for(let i = 0;i< arr.length ;i++){
       if(arr[i] > 0){positiveSum++}
       else if(arr[i] < 0){negativeSum++}
       else{zeroSum++}
    }
    let positiveResult = positiveSum/arr.length;
    console.log(positiveResult.toFixed(6));
    let negativeResult = negativeSum/arr.length;
    console.log(negativeResult.toFixed(6));
    let zeroResult = zeroSum/arr.length;
    console.log(zeroResult.toFixed(6));

}