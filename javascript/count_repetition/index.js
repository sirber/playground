function countRepetition(source) {
  const map = new Map()
  let count = 0

  for (const num of source) {
    if (map.has(num)) {
      map.set(num, map.get(num) + 1)
    } else {
      map.set(num, 0)
    }
  }

  Array
    .from(map, ([key, value]) => {
      count += value
    })

  return count
}

module.exports = {
  countRepetition
}