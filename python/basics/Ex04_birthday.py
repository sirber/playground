months = ("janvier", "février", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "décembre")
birthdate = input("Votre date de naissance (JJ-MM-AAAA)? ")
print("Vous êtes né en:", months[int(birthdate[3:5])-1])
