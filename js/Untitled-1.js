function groupBy(list, name) {
  return list.reduce((obj, item) => {
    if (!obj[item[name]]) {
      obj[item[name]] = []
      obj[item[name]].push(item)
    } else {
      obj[item[name]].push(item)
    }
    return obj
  },{})
}
let list = [
    {"name": "John","Average":15,"High":10,"DtmStamp":1358226000000},
    {"name": "Jane","Average":16,"High":92,"DtmStamp":1358226000000},
    {"name": "Jane","Average":17,"High":45,"DtmStamp":1358226000000},
    {"name": "John","Average":18,"High":87,"DtmStamp":1358226000000},
    {"name": "Jane","Average":15,"High":10,"DtmStamp":1358226060000},
    {"name": "John","Average":16,"High":87,"DtmStamp":1358226060000},
    {"name": "John","Average":17,"High":45,"DtmStamp":1358226060000},
    {"name": "Jane","Average":18,"High":92,"DtmStamp":1358226060000}
];
const g = groupBy(list, 'name')

console.log(g)