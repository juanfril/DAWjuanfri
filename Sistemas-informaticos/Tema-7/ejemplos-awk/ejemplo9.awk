# Muestra el precio de los productos sin IVA
function precioSinIva(precio) {
    return precio/(1+IVA/100)
}
BEGIN {
    FS=";"
    IVA=21
}
{
    printf "Producto: %s. Precio sin IVA: %.2f€. Precio final: %.2f€\n",$3,precioSinIva($4),$4
}
