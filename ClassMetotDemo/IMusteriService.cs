using System.Collections.Generic;

namespace ClassMetotDemo;

public interface IMusteriService
{
    void Add(Musteri musteri);
    void List(Musteri musteri);
    void Delete(Musteri musteri);
}