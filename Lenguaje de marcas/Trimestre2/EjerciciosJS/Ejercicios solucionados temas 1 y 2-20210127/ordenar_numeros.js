'use script';

let numeros = [80, 1, 4, 2];

for (let i = 0; i < numeros.length -1; i++) {
    for (let j = 0; j < numeros.length; j++) {
        
        if(numeros[i] > numeros[j]){
            let provisional = numeros[i];
            numeros[i] = numeros[j];
            numeros[j] = provisional;
        }
    }

}

for (let i = 0; i < numeros.length; i++) {
    console.log(numeros[i]);
}