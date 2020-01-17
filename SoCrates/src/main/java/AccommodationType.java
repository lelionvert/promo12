public enum AccommodationType {

    SINGLE(610),
    TWIN(510),
    TRIPLE(410),
    NONE(240);

    public int price;

    AccommodationType(int price) {
        this.price = price;
    }
}