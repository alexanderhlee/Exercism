export const gigasecond = (d) => {
  const GIGASECOND = Math.pow(10,9);
  let newDate = new Date(d);
  newDate.setTime(d.getTime() + GIGASECOND * 1000);
  return newDate;
};
