 #include <stdio.h>
 #include "calcula.h" /* Criado pelo rpcgen */

 float add( CLIENT *clnt, float x, float y) {
     operandos ops;
     float *result;

     ops.x = x; 
     ops.y = y;

     /* Chama o stub cliente criado pelo rpcgen */
     result = add_100(&ops,clnt);

     if (result==NULL) {
         fprintf(stderr,"Problema na chamada RPC\n");
         exit(0); 
    }

     return(*result);

 } /* fim função add local */



 float sub( CLIENT *clnt, float x, float y) {
     operandos ops;
     float *result;

     /* Preenche struct operandos para ser enviada ao outro lado */
     ops.x = x;
     ops.y = y;

     /* Chama o stub cliente criado pelo rpcgen */
     result = sub_100(&ops,clnt);

     if (result==NULL) {
         fprintf(stderr,"Problema na chamada RPC\n");
         exit(0);
     }

     return(*result);

 } /* fim funcao sub local */



 float mult( CLIENT *clnt, float x, float y) {
     operandos ops;
     float *result;

     ops.x = x; 
     ops.y = y;

     /* Chama o stub cliente criado pelo rpcgen */
     result = mult_100(&ops,clnt);

     if (result==NULL) {
         fprintf(stderr,"Problema na chamada RPC\n");
         exit(0); 
    }

     return(*result);

 } /* fim função mult local */



 float divi( CLIENT *clnt, float x, float y) {
     operandos ops;
     float *result;

     ops.x = x; 
     ops.y = y;

     /* Chama o stub cliente criado pelo rpcgen */
     result = divi_100(&ops,clnt);

     if (result==NULL) {
         fprintf(stderr,"Problema na chamada RPC\n");
         exit(0); 
    }

     return(*result);

 } /* fim função divi local */



 float main( int argc, char *argv[]) {
     CLIENT *clnt;
     float x,y;
     int opcao;

     printf("================  Cliente RPC  ================\n");
     printf("Digite o número da opção que deseja executar:\n");
     printf("1 - Soma \n");
     printf("2 - Subtração \n");
     printf("3 - Multiplicação \n");
     printf("4 - Divisão \n");
     printf("===============================================\n");
     scanf("%d", &opcao);
     printf("===============================================\n");
     printf("Informe o primeiro valor (x): ");
     scanf("%f", &x);
     printf("Informe o segundo valor (y): ");
     scanf("%f", &y);
     printf("===============================================\n");


     clnt = clnt_create(argv[1], PROG, VERSAO, "udp");


     /* Garantindo a criacao da ligacao com o remoto */
     if (clnt == (CLIENT *) NULL) {
         clnt_pcreateerror(argv[1]);
         exit(0); 
    }

    switch(opcao) {
        case 1:
                printf("Servidor processou o seguinte resultado: \n");
                printf("%.2f + %.2f = %.2f\n\n",x,y, add(clnt,x,y));
                break;

        case 2:
                printf("Servidor processou o seguinte resultado: \n");
                printf("%.2f - %.2f = %.2f\n\n",x,y, sub(clnt,x,y));
                break; 

        case 3:
                printf("Servidor processou o seguinte resultado: \n");
                printf("%.2f * %.2f = %.2f\n\n",x,y, mult(clnt,x,y));
                break;  

        case 4:
                if(y != 0){
                    printf("Servidor processou o seguinte resultado: \n");
                    printf("%.2f / %.2f = %.2f\n\n",x,y, divi(clnt,x,y));
                }
                else{
                    printf("Nao existe divisao por 0 (zero). \n");
                }
                break;  

        default:
                printf("Opcao invalida! \n\n");
                break;               
    }

    return(0);

 } /* fim main */