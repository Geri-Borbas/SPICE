//
//  main.c
//  SPICE_Sandbox
//
//  Created by eppz! on 2018. 01. 18..
//  Copyright © 2018. eppz!. All rights reserved.
//

#include <stdio.h>
#include "HelloWorld.h"
#include "SpiceUsr.h"


int main(int argc, const char * argv[])
{
    
    printf("Hello, World!\n");
    printf("%f", CubeArea(2.0));
    
    furnsh_c("Batman.spk");
    return 0;
}
