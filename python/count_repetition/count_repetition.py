def count_repetition(source):
  count = 0
  map = {}

  for number in source:
    value = map.get(number)
    
    if value is not None:
      map[number] = value + 1
    else:
      map[number] = 0

  for key, value in map.items():
    count += value

  return count