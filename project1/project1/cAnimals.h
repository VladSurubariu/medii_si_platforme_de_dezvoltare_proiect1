#pragma once
#include <iostream>
#include <string>

class cAnimals
{
protected:
  std::string animals[5] = { "dog", "cat", "cow", "sheep", "pigeon" };
  std::string sounds[5] = { "woof", "meow", "moo", "baa", "coo coo" };

public:
  void fAnimalsAndSounds()
  {
    for (int i = 0; i < 5; i++)
    {
      std::cout << animals[i] << " makes sound : " << sounds[i] << std::endl;
    }
  }
};
