# Ejemplo de bucle while
BEGIN { FS = ";" }
{
    i = 1
    while (i <= $5) {
        printf "%d unidades de %s cuestan: %.2f€\n", i, $3,($4*i)
        i++
    }
}
