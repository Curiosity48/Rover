const int   MAXEL = 100;
const int triggerPort = 9;
const int echoPort = 10;

float v [MAXEL];  
int numEl=0;
void setup() {
 
pinMode(triggerPort, OUTPUT);
pinMode(echoPort, INPUT);
Serial.begin(9600);
Serial.print( "Sensore Ultrasuoni: ");
}
 
void loop() {
 
//porta bassa l'uscita del trigger
digitalWrite( triggerPort, LOW );
//invia un impulso di 10microsec su trigger
digitalWrite( triggerPort, HIGH );
delayMicroseconds( 10 );
digitalWrite( triggerPort, LOW );
 
float durata = pulseIn( echoPort, HIGH );
 
float distanza = 0.034 * durata / 2;
 
//Serial.print("distanza: ");
 
//dopo 38ms è fuori dalla portata del sensore
if( durata > 38000 ){
//Serial.println("Fuori portata   ");
distanza = -1;

}
else{ 
//Serial.print(distanza); 
//Serial.println(" cm     ");


//Comunica a BlueTooth
}
push(distanza);
if(numEl==MAXEL){
  for (int i=0; i<numEl; i++)
    Serial.println(v[i]);
    }

//Aspetta 1000 microsecondi
delayMicroseconds(10000);
}

void push(float dist)
{
  if(numEl<MAXEL)
  {
    v[numEl] = dist;
    numEl++;
  }
  else
  {
    for (int i=0; i<numEl; i++)
      v[i]=0;
    numEl=0;
  }
  }

  



