struct operandos {
    float x;
    float y; 
};

program PROG {
    version VERSAO {
        float ADD(operandos) = 1;
        float SUB(operandos) = 2;
        float MULT(operandos) = 3;
        float DIVI(operandos) = 4;
    } = 100;
} = 55555555;