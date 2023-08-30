/*
 * Complete the reverseString function
 * Use console.log() to print to stdout.
 */
function reverseString(s) {
    try{
       s = s.split('').reverse().join("")
        
    }
    catch(error){
        console.log(error.message)
    }
    finally{
       console.log(s)   
    }
}
