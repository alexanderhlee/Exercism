import java.time.Duration;
import java.time.LocalDate;
import java.time.LocalDateTime;

class Gigasecond {
    private LocalDateTime _moment;
    final Duration GIGA_SECOND = Duration.ofSeconds(1_000_000_000L);

    Gigasecond(LocalDate moment) {
        this(moment.atStartOfDay());
    }

    Gigasecond(LocalDateTime moment) {
        _moment = moment;
    }

    LocalDateTime getDateTime() {
        return _moment.plus(GIGA_SECOND);
    }
}
