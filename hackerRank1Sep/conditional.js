function main() {
    const N = parseInt(readLine().trim(), 10);
    const result = 
    (
        (N % 2 === 1 || (N % 2 === 0 && N >= 6 && N <= 20)) 
        ? "Weird"
        : "Not Weird"
    )
    console.log(result)
}

//https://www.hackerrank.com/challenges/30-conditional-statements/problem?isFullScreen=true