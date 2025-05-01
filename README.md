# PP_NominasBack - Estandarización Inicial

Este proyecto ha sido procesado como parte de una limpieza y normalización estructural del backend en ASP.NET Core (.NET 9) con MongoDB.

## ✅ Cambios realizados

1. **Normalización de nombres de carpetas y archivos**:
   - Se eliminaron tildes y caracteres especiales.
   - Se aplicó PascalCase a todos los nombres de carpetas y archivos `.cs`.

2. **Estructura modular mantenida**:
   - Modelos dentro de `Models/Catalogos/[Seccion]/`.
   - DTOs dentro de `DTOs/Catalogos/[Seccion]/`.
   - Enums preparados para consolidarse en `Models/Shared/CatalogoEnums.cs`.

3. **Preparación para próximos pasos**:
   - Regeneración completa de `CatalogosProfile.cs`.
   - Validación de AutoMapper.
   - Limpieza de propiedades genéricas y duplicadas.
   - Validación contra `TablaEjemplosV2.xlsx` y `Errores.txt`.

## 🧱 Estructura base establecida

```
PP_NominasBack/
├── Models/
│   └── Catalogos/[Seccion]/[Modelo].cs
│   └── Shared/
├── Dtos/
│   └── Catalogos/[Seccion]/[ModeloDto].cs
│   └── Shared/
├── Profiles/CatalogosProfile.cs
├── Services/
```

Este es el primer paso de limpieza, en los siguientes pasos se generará el código limpio, validado y con mapeos correctos.

---

**Fecha de estandarización:** 2025-05-01  
**Automatizado por:** ChatGPT (.NET 9 | MongoDB | AutoMapper | Clean Architecture)
