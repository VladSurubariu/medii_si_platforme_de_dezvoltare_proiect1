#include "cAnimals.h"

int main()
{
  /* Animals object */
  clAnimals animals;

  /* Variables init */
  std::string animal_name = "";
  int iAnimalID = INVALID;

  /* Get input */
  std::cout << "I wonder how this animal sounds like: ";
  std::cin >> animal_name;
  std::cout << std::endl;

  /* Search the input in animal list. Return INVALId if it doesn't exist or index otherwise */
  iAnimalID = animals.getAnimalIDByName(animal_name);

  if (iAnimalID == INVALID)
  {
    std::cout << "Is that even an animal?"<<std::endl;
  }
  else
  {
    std::cout << "I know! The " << animal_name << " makes sound: " << animals.getAnimalSound(iAnimalID);
  }

  return 0;
}

