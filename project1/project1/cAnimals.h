#pragma once
#include <iostream>
#include <string>

/* The number of animals and sounds defined */
#define ANIMALS_COUNT 5

/* Invalid value used for testing out of range input */
#define INVALID 1000

class clAnimals
{
protected:
  /* List of animal names */
  std::string animals[ANIMALS_COUNT] = { "dog", "cat", "cow", "sheep", "pigeon" };
  /* List of sounds for the animals list */
  std::string sounds[ANIMALS_COUNT] = { "woof", "meow", "moo", "baa", "coo coo" };

public:
  /* Function that returns a list of all animals and sounds available */
  void funAnimalsAndSounds()
  {
    for (int ix = 0; ix < ANIMALS_COUNT; ix++)
    {
      std::cout << animals[ix] << " makes sound : " << sounds[ix] << std::endl;
    }
  }

  /* Get function that returns the ID of an animal or INVALID if the animal is not in the list */
  int getAnimalIDByName(std::string animalName)
  {
    for (int ix = 0; ix < ANIMALS_COUNT; ix++)
    {
      if (animalName.compare(animals[ix]) == 0)
      {
        return ix;
      }
    }

    return INVALID;
  }

  /* Get function that returns the sound of an animal if that animal is in list, or INVALID otherwise */
  std::string getAnimalSound(int ix)
  {
    if (ix != INVALID)
    {
      return sounds[ix];
    }
  }

};
