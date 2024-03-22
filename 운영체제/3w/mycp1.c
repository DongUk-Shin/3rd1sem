#include <unistd.h>
#include <stdio.h>
#define NAME_LENGTH 25

int main(int argc, char *argv[]) {

    FILE *in, *out;
    int c;

    in_file = argv[1];
    out_file = argv[2];
    
    if ( (in = fopen(argv[1],"r")) == NULL) {
        fprintf(stderr,"Cannot open %s for reading\n",argv[1]);
        return -1;
    }

    if ( (out = fopen(argv[2],"w")) == NULL) {
        fprintf(stderr,"Cannot open %s for writing\n",argv[2]);
        return -1;
    }

    while ( (c = getc(in)) != EOF)
        putc(c,out);


    fclose(in);
    fclose(out);
    return 0;
}