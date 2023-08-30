/*Task

Complete the getLetter(s) function in the editor. It has one parameter: a string ,s, consisting of lowercase
 English alphabetic letters (i.e., a through z). It must return A, B, C, or D depending on the following criteria:

    If the first character in string  is in the set {a,e,i,o,u}, then return A.
    If the first character in string  is in the set {b,c,d,f,g}, then return B.
    If the first character in string  is in the set {h,j,k,l,m}, then return C.
    If the first character in string  is in the set {n,p,q,r,s,t,v,w,x,y,z}, then return D.
 */
function getLetter(s) {
    let letter;
    
    switch(s.charAt(0))
    {
        case ('a' || 'e' || 'i' || 'o' || 'u'):
         letter='A';
          break;
        case ('b' || 'c' || 'd' || 'f' || 'g'):
        letter='B';
         break;
        case ('h' || 'j' || 'k' || 'l' || 'm'):
        letter='C';
         break;
    case ('z'||'n'||'p'||'q'||'r'||'s'||'t'||'v'||'w'||'x'||'y'):
        letter='D';
         break;
       
    }
    
    return letter;
}
