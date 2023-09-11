class Hello {
    constructor(name,greeting){
       this.name = name;
       this.greeting = greeting;
    }
}


const hi = new Hello("Sonalika","Hi");//creating hi object
const gm = new Hello("John Doe", "Good Morning")//creating gm object

console.log(hi.greeting,hi.name,gm.greeting,gm.name);

//adding new prototype property
Hello.prototype.place = "India";
console.log(hi.place)

//adding new prototype method
Hello.prototype.meth = function(){
    return this.name + " belongs to "+this.place
}

console.log(gm.meth())