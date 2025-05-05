 #include "calcula.h"


 float * add_100_svc(operandos *argp, struct svc_req *rqstp) {

    static float result;

    printf("================  Servidor RPC  ================\n");
    printf("Requisicao de adicao para %.2f e %.2f\n", argp->x, argp->y);
    result = argp->x + argp->y;
    printf("Resultado da adicao: %.2f \n\n", result);
    return &result;
 
 } /* fim da função add remota */



 float * sub_100_svc(operandos *argp, struct svc_req *rqstp) {

    static float result;

    printf("================  Servidor RPC  ================\n");
    printf("Requisicao de subtracao para %.2f e %.2f\n", argp->x, argp->y);
    result = argp->x - argp->y;
    printf("Resultado da subtracao: %.2f \n\n", result);
    return &result;
 
 } /* fim da função sub remota */



float * mult_100_svc(operandos *argp, struct svc_req *rqstp) {

    static float result;

    printf("================  Servidor RPC  ================\n");
    printf("Requisicao de multiplicacao para %.2f e %.2f\n", argp->x, argp->y);
    result = argp->x * argp->y;
    printf("Resultado da multiplicacao: %.2f \n\n", result);
    return &result;
 
 } /* fim da função mult remota */



float * divi_100_svc(operandos *argp, struct svc_req *rqstp) {

    static float result;

    printf("================  Servidor RPC  ================\n");
    printf("Requisicao de divisao para %.2f e %.2f\n", argp->x, argp->y);
    result = argp->x / argp->y;
    printf("Resultado da divisao: %.2f \n\n", result);
    return &result;
 
 } /* fim da função divi remota */    